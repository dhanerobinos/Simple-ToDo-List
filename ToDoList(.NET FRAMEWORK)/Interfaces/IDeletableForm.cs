using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Interfaces
{
    public interface IDeletableForm<T>
    {
        T GetSelectedItem(); // returns the selected item from the UI (like a ListView or DataGrid)
    }
}
