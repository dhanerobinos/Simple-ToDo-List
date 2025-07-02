using System;
using ToDoList.Interfaces;
using System.Windows.Forms;
namespace ToDoList.Handlers
{
    public static class DeleteHandler
    {
        public static void HandleDelete<T>(IDeletableForm<T> form, Action<T> deleteAction)
        {
            var DeleteItem = form.GetSelectedItem();
            if (DeleteItem == null)
            {
                MessageBox.Show("Please select an item to delete.", "No Item Selected");
                return;
            }

            var confirmationResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Deletion", MessageBoxButtons.YesNo);

            if (confirmationResult == DialogResult.Yes)
            {
                try
                {
                    deleteAction(DeleteItem);
                    MessageBox.Show("Item deleted successfully.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the item: {ex.Message}", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Deletion cancelled.", "Deletion Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
