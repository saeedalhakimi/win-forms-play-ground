using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplayGround
{
    public partial class frmCheckedListitems : Form
    {
        public frmCheckedListitems()
        {
            InitializeComponent();
        }
        private bool _isChecked;
        private void button1_Click(object sender, EventArgs e)
        {
            // Get the last item in the checkedListBox.
            var lastItem = checkedListBox1.Items.Cast<string>().LastOrDefault();

            // Get the number of the last item.
            var lastNumber = int.TryParse(lastItem?.Substring(5), out var result) ? result : 0;

            // Add the items to the checkedListBox starting from the last number.
            // Create an array of 10 integers from the last number + 1 to the last number + 10.
            // Convert each integer to a string with the format "Item {i}".
            // Convert the array to an object array.
            checkedListBox1.Items.AddRange(Enumerable.Range(lastNumber + 1, 10).
                Select(i => "Item " + i).ToArray());




            //// Add the items to the checkedListBox.
            //checkedListBox1.Items.AddRange(
            //    // Create an array of 10 integers from 1 to 10.
            //    Enumerable.Range(1, 10)
            //    // Convert each integer to a string with the format "Item {i}".
            //    .Select(i => "Item " + i)
            //    // Convert the array to an object array.
            //    .ToArray());


            //foreach (int i in Enumerable.Range(1, 10))
            //{
            //    checkedListBox1.Items.Add("Item " + i);
            //}

            //for (int i = 1; i < 11;  i++)
            //{
            //    checkedListBox1.Items.Add("Item " + i);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Get the checked items from the checkedListBox.
            var checkedItems = checkedListBox1.CheckedItems;

            // If there are no checked items, return without showing the message box.
            if (checkedItems.Count == 0)
            {
                return;
            }

            // Join the checked items into a single string with a new line separator.
            var message = string.Join(Environment.NewLine, checkedItems.Cast<object>());

            // Show a message box with the checked items.
            MessageBox.Show(message);


            //foreach (var item in checkedListBox1.CheckedItems)
            //{
            //    MessageBox.Show(item.ToString());
            //}

            //for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            //{
            //    MessageBox.Show(checkedListBox1.CheckedItems[i].ToString());
            //}
        }


        private void button3_Click(object sender, EventArgs e)
        {
            // Prevent the checkedListBox from redrawing itself for each item that is checked.
            checkedListBox1.BeginUpdate();
            _isChecked = !_isChecked;
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, _isChecked);
            }
            // Allow the checkedListBox to redraw itself.
            checkedListBox1.EndUpdate();
            if (_isChecked)
            {
                button3.Text = "Uncheck All";
            }
            else
            {
                button3.Text = "Check All";
            }

            //// Prevent the checkedListBox from redrawing itself for each item that is checked.
            //checkedListBox1.BeginUpdate();
            //if (!_isChecked)
            //{
            //    // Check all the items.
            //    for (int i = 0; i < checkedListBox1.Items.Count; i++)
            //    {
            //        checkedListBox1.SetItemChecked(i, true);
            //    }
            //    _isChecked = true;
            //}
            //else
            //{
            //    // Uncheck all the items.
            //    for (int i = 0; i < checkedListBox1.Items.Count; i++)
            //    {
            //        checkedListBox1.SetItemChecked(i, false);
            //    }
            //    _isChecked = false;
            //}
            //// Allow the checkedListBox to redraw itself.
            //checkedListBox1.EndUpdate();


            //// Prevent the checkedListBox from redrawing itself for each item that is checked.
            //checkedListBox1.BeginUpdate();
            //for (int i = 0; i < checkedListBox1.Items.Count; i++)
            //{
            //    // Toggle the checked state of the item at index i.
            //    checkedListBox1.SetItemChecked(i, !checkedListBox1.GetItemChecked(i));
            //}
            //// Allow the checkedListBox to redraw itself.
            //checkedListBox1.EndUpdate();



            //// Prevent the checkedListBox from redrawing itself for each item that is checked.
            //checkedListBox1.BeginUpdate();
            //for (int i = 0; i < checkedListBox1.Items.Count; i++)
            //{
            //    // Check the item at index i.
            //    checkedListBox1.SetItemChecked(i, true);
            //}
            //// Allow the checkedListBox to redraw itself.
            //checkedListBox1.EndUpdate();

            //for (int i = 0; i < checkedListBox1.Items.Count; i++)
            //{
            //    checkedListBox1.SetItemChecked(i, true);
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.RemoveAt(2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
        }
    }
}
