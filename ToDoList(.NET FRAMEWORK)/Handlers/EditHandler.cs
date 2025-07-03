using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.Interfaces;

namespace ToDoList.Handlers
{
    public class EditHandler
    {
        public static void HandleEdit<T>(IEditableForm<T> editableForm, T existingData, Action<T> onEdit)
        {
            editableForm.LoadData(existingData);
            using (Form form = editableForm as Form)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    T editedData = editableForm.GetEditedData();
                    onEdit(editedData);
                }
            }
        }
        public static void HandleEditSave<T>(
       IEditableForm<T> form,
       Action<T> updateAction,
       Action postUpdate = null)
        {
            var updatedData = form.GetEditedData();
            updateAction(updatedData);        // e.g. _taskService.UpdateTask(model)
            postUpdate?.Invoke();             // optional: refresh UI, hide panel, etc
        }

    }
}


     
