using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Interfaces
{
    public interface ICompletableForm<T>
    {
        T GetSelectedItem();
        void MarkAsCompleted(T task);
    }
}
