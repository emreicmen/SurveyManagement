using CommonLayer;
using DataAccessLayer;
using EntityLayer;
using EntityLayer.Messages;
using EntityLayer.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    //Arayüz ile Database arasındaki SystemUser işlerinde bağlantı katmanıdır
    public class UserManager : ManagerBase<SystemUsers>
    {
        private Repository<SystemUsers> repo_users = new Repository<SystemUsers>();

        public BusinessLayerResult<SystemUsers> RegisterUser(RegisterViewModel data)
        {
            SystemUsers user = Find(x => x.UserName == data.Username || x.Email == data.Email);
            BusinessLayerResult<SystemUsers> res = new BusinessLayerResult<SystemUsers>();

            if (user != null)
            {
                if (user.UserName == data.Username)
                {
                    res.AddError(ErrorMessageCode.UsernameAlreadyExist, "Username already Exists!");
                }
                if (user.Email == data.Email)
                {
                    res.AddError(ErrorMessageCode.EmailAlreadyExist, "E-mail address already exists!");
                }
            }
            else
            {
                int dbResult = base.Insert(new SystemUsers()
                {
                    Authorization = data.Authorization,
                    Name = data.Name,
                    Surname = data.Surname,
                    Age = data.Age,
                    UserName = data.Username,
                    Email = data.Email,
                    Password = data.Password,
                    CompanyID = data.CompanyID,
                    Country = data.Country,
                    City = data.City
                });
            }
            return res;
        }

        public BusinessLayerResult<SystemUsers> LoginUser(LoginViewModel data)
        {
            BusinessLayerResult<SystemUsers> res = new BusinessLayerResult<SystemUsers>();
            res.Result = Find(x => x.UserName == data.Username && x.Password == data.Password);

            if (res.Result != null)
            {

            }
            else
            {
                res.AddError(ErrorMessageCode.UsernameOrPassWrong, "Username or password are not matching!");
            }
            return res;
        }

        public BusinessLayerResult<SystemUsers> GetUserById(int id)
        {
            BusinessLayerResult<SystemUsers> res = new BusinessLayerResult<SystemUsers>();
            res.Result = Find(x => x.SystemUserID == id);
            if (res.Result == null)
            {
                res.AddError(ErrorMessageCode.UserNotFound, "User not found....");
            }
            return res;
        }

        public List<SystemUsers> GetUsers()
        {
            return repo_users.List();
        }
    }
}
