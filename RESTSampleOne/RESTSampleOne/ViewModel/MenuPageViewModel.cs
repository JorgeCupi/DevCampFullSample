using RESTSampleOne.Model;
using RESTSampleOne.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTSampleOne.ViewModel
{
    class MenuPageViewModel
    {
        //Obteniendo dinamicamente informacion de un server
        public List<Option> Options
        {
            get
            {
                return new List<Option>()
                {
                    new Option() {optionName = "User", TargeType = typeof(UserPage) },
                    new Option() {optionName = "ToDo's", TargeType= typeof(ToDoPage)},
                    new Option() {optionName = "Comments", TargeType=typeof(CommentPage)},
                    new Option() {optionName = "Posts", TargeType=typeof(PostPage) },
                    new Option() { optionName = "FAQs", TargeType= typeof(PostPage)}
                };
            }
        }
    }

}
