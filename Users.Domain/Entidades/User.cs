using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Windows.Documents;
using TodoApi.Models;

namespace Users.Domain
{

    public class User
    {


        public int Id { get; set; }

        public string Name { get; set; }
    }
}
namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public string Secret { get; set; }



    }
}