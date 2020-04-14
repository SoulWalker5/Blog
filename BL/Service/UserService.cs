using AutoMapper;
using BL.BLModel;
using DAL.Entity;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Service
{
    public interface IUserService : IGenericService<UserBL>
    {

    }
    public class UserService : GenericService<UserBL, User>, IUserService
    {
        private readonly IMapper _mapper;

        public UserService(IGenericRepository<User> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public override UserBL Map(User model)
        {
            return _mapper.Map<UserBL>(model);
        }
        public override User Map(UserBL model)
        {
            return _mapper.Map<User>(model);
        }

        public override IEnumerable<UserBL> Map(IList<User> entitiesList)
        {
            return _mapper.Map<IEnumerable<UserBL>>(entitiesList);
        }
        public override IEnumerable<User> Map(IList<UserBL> entitiesList)
        {
            return _mapper.Map<IEnumerable<User>>(entitiesList);
        }
    }
}
