using System.ComponentModel.DataAnnotations;

namespace HYE_SocialNetwork.ViewModels
{
    public class HYEPrefix : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            //Check to see if question begins with the words "Have you ever..."

            return base.IsValid(value);
        }
    }
}