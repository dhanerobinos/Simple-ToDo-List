using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Interfaces
{
    public interface IAddableForm<T>
    {
        T GetNewData(string title, DateTime dueDate); //converts input to a model
        void AddData(T data); //adds the model to the form's list/database
    }
}
