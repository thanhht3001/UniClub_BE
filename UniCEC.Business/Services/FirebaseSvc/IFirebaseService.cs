using Firebase.Auth;
using System.Threading.Tasks;
using UniCEC.Data.ViewModels.Entities.User;
using UniCEC.Data.ViewModels.Firebase.Auth;

namespace UniCEC.Business.Services.FirebaseSvc
{
    public interface IFirebaseService
    {
        public Task<ViewUserInfo> Authentication(string token, string deviceId);
        public Task<FirebaseAuthLink> GetFirebaseToken(UserLoginModel model);
    }
}
