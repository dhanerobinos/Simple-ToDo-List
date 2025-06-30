using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Interfaces
{
    public interface ICRUDForm
    {
        void AddTask();
        void UpdateTask();
        void DeleteTask();
    }
}
