using Poll.Application.DTO.DTO;
using Poll.Application.Interfaces;
using Poll.Domain.Core.Interfaces.Services;
using Poll.Infrastructure.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace Poll.Application.Service
{
    public class ApplicationServicePollOption : IApplicationServicePollOption
    {
        private readonly IServicePollOption _servicePollOption;
        private readonly IMapperPollOption _mapperPollOption;
        public ApplicationServicePollOption(IServicePollOption ServicePollOption, IMapperPollOption MapperPollOption)

        {
            _servicePollOption = ServicePollOption;
            _mapperPollOption = MapperPollOption;
        }

        public int Add(NewPollOptionDTO obj)
        {
            var objPollOption = _mapperPollOption.MapperToEntity(obj);
            return _servicePollOption.Add(objPollOption);
        }

        public void Dispose()
        {
            _servicePollOption.Dispose();
        }

        public IEnumerable<PollOptionDTO> GetPollOptions(int id)
        {
            var objPollOptions = _servicePollOption.GetPollOptions(id);
            return _mapperPollOption.MapperListPollOptions(objPollOptions);
        }

        public PollOptionDTO GetById(int id)
        {
            var objPollOption = _servicePollOption.GetById(id);
            return _mapperPollOption.MapperToDTO(objPollOption);
        }
    }
}
