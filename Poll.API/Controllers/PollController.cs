using System;
using Poll.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Poll.API.Models;
using Poll.Application.DTO.DTO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace Poll.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PollController : ControllerBase
    {
        private readonly IApplicationServicePoll _applicationServicePoll;
        private readonly IApplicationServicePollOption _applicationServicePollOption;
        private readonly IApplicationServicePollVotes _applicationServicePollVotes;
        private readonly IApplicationServicePollStats _applicationServicePollStats;

        public PollController(IApplicationServicePoll ApplicationServicePoll,
                              IApplicationServicePollOption ApplicationServicePollOption,
                              IApplicationServicePollVotes ApplicationServicePollVotes,
                              IApplicationServicePollStats ApplicationServicePollStats)
        {
            _applicationServicePoll = ApplicationServicePoll;
            _applicationServicePollOption = ApplicationServicePollOption;
            _applicationServicePollVotes = ApplicationServicePollVotes;
            _applicationServicePollStats = ApplicationServicePollStats;
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var poll = _applicationServicePoll.GetById(id);
            if (poll != null)
            {
                var poll_options = _applicationServicePollOption.GetPollOptions(id);
                var viewModel = new PollViewModel(poll, poll_options);
                return Ok(viewModel);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] NewPollDTO newPoll)
        {
            try
            {
                if (newPoll == null) return NotFound();

                int poll_id = _applicationServicePoll.Add(newPoll);
                if (newPoll.options != null)
                {
                    foreach (string option in newPoll.options)
                    {
                        var newPollOptionDTO = new NewPollOptionDTO() { poll_id = poll_id, option_description = option };
                        _applicationServicePollOption.Add(newPollOptionDTO);
                    }
                }
                return Ok(new NewPollResult()
                {
                    poll_id = poll_id
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("{poll_id}/vote")]
        public ActionResult Vote(int poll_id, [FromBody] PollOptionDTO newPollOption)
        {
            var poll = _applicationServicePoll.GetById(poll_id);
            if (poll == null) return NotFound();
            if (newPollOption == null) return NotFound();
            if (newPollOption.option_id == 0) return NotFound();

            var poll_option = _applicationServicePollOption.GetById(newPollOption.option_id);
            if (poll_option != null)
            {
                var poll_votes = _applicationServicePollVotes.GetPollVotes(poll_id, newPollOption.option_id);
                if (poll_votes.Count() == 0)
                {
                    return Ok(_applicationServicePollVotes.Add(new PollVotesDTO() { poll_id = poll_id, option_id = newPollOption.option_id, qty = 1 }));
                }
                else
                {
                    var voteToUpdate = poll_votes.SingleOrDefault();
                    _applicationServicePollVotes.Update(new PollVotesDTO() { vote_id = voteToUpdate.vote_id, poll_id = voteToUpdate.poll_id, option_id = voteToUpdate.option_id, qty = voteToUpdate.qty + 1 });
                    return Ok();
                }
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{poll_id}/stats")]
        public ActionResult Stats(int poll_id)
        {
            int views = 0;
            var poll = _applicationServicePoll.GetById(poll_id);
            if (poll == null) return NotFound();

            var poll_stats = _applicationServicePollStats.GetPollStats(poll_id);
            if (poll_stats.Count() == 0)
            {
                views = 1;
                var pollStatsDTO = new PollStatsDTO() { poll_id = poll_id, views = views };
                _applicationServicePollStats.Add(pollStatsDTO);
            }
            else
            {
                var statToUpdate = poll_stats.SingleOrDefault();
                views = statToUpdate.views + 1;
                _applicationServicePollStats.Update(new PollStatsDTO() { stat_id = statToUpdate.stat_id, poll_id = statToUpdate.poll_id,  views = views });
            }

            var poll_votes = _applicationServicePollVotes.GetPollVotes(poll_id);
            var votes = new List<VoteViewModel>();
            foreach (var item in poll_votes)
            {
                votes.Add(new VoteViewModel() { option_id = item.option_id, qty = item.qty });
            }
            var stats_viewModel = new StatsViewModel()
            {
                views = views,
                votes = votes
            };

            return Ok(stats_viewModel);
        }
    }
}