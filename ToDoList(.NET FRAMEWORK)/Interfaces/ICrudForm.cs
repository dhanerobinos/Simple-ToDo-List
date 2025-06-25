using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Interfaces
{
    public interface ICrudForm
    {
        void AddEntry();
        void UpdateEntry();
        void DeleteEntry();
    }
}
