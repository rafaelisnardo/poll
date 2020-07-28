using Poll.Application.DTO.DTO;
using Poll.Infrastructure.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace Poll.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperPollOption : IMapperPollOption
    {
        #region properties
        List<PollOptionDTO> PollOptionDTOs = new List<PollOptionDTO>();
        #endregion

        #region methods
        public Poll.Domain.Models.PollOption MapperToEntity(NewPollOptionDTO PollOptionDTO)
        {
            Poll.Domain.Models.PollOption PollOption = new Poll.Domain.Models.PollOption
            {
                poll_id = PollOptionDTO.poll_id,
                option_description = PollOptionDTO.option_description
            };

            return PollOption;
        }

        public IEnumerable<PollOptionDTO> MapperListPollOptions(IEnumerable<Poll.Domain.Models.PollOption> PollOptions)
        {
            foreach (var item in PollOptions)
            {
                PollOptionDTO PollOptionDTO = new PollOptionDTO
                {
                    option_id = item.option_id,
                    option_description = item.option_description
                };

                PollOptionDTOs.Add(PollOptionDTO);
            }

            return PollOptionDTOs;
        }

        public PollOptionDTO MapperToDTO(Poll.Domain.Models.PollOption PollOption)
        {
            if (PollOption != null)
            {
                PollOptionDTO PollOptionDTO = new PollOptionDTO
                {
                    option_id = PollOption.option_id,
                    option_description = PollOption.option_description
                };

                return PollOptionDTO;
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
