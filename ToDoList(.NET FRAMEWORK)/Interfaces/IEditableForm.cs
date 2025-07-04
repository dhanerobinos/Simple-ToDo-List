using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Interfaces
{
    public interface IEditableForm<T>
    {
        void LoadData(T data);         // to fill the form
        T GetEditedData(string title, DateTime dueDate);
    }
}
