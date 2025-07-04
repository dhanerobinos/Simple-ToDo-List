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
        public static void HandleEdit<T>(IEditableForm<T> editableForm,  T existingData, Func<T> getEditedData,Action<T> onEdit)
        {
            editableForm.LoadData(existingData);

            using (Form form = editableForm as Form)
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    T editedData = getEditedData();  // this calls your lambda
                    onEdit(editedData);
                }
            }
        }
        public static void HandleEditSave<T>(
                                             IEditableForm<T> form,
                                             string title,
                                             DateTime dueDate,
                                             Action<T> updateAction,
                                             Action postUpdate = null)
        {
            var updatedData = form.GetEditedData(title, dueDate);
            updateAction(updatedData);
            postUpdate?.Invoke();
        }



    }
}


     
