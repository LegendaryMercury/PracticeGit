using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ContainerManagerMkII.Form1.ShippingContainer;
/*
 * Program by Lachlan Astell
 * This program is a container database, you are supposed to enter a container's details and then be able to use it for whatever.
 * This program is for practice and will grow as i need it too.
 * Date of creation 27/04/2025 11:29pm
 */
namespace ContainerManagerMkII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Our container Object, Star of the show for now.
        public class ShippingContainer
        {
            // Containers come in two sizes, so i created a custom variable for them.
            public enum ContainerSize
            {
                Twentyfeet,
                Fortyfeet
            }
            // Set variables for container
            public string ContNumber { get; set; }
            public int ContWeight { get; set; }
            public double ContCapacity { get; set; }
            public ContainerSize ContSize { get; set; }

            // This is a constructor, it lets us quickly make new itterations of the object.
            public ShippingContainer(string number, int weight, double capacity, ContainerSize size)
            {
                ContNumber = number;
                ContWeight = weight;
                ContCapacity = capacity;
                ContSize = size;
            }
            // This allows us to generate the string output and tells the form, or list box in this case, how to put the output string together.
            public override string ToString()
            {
                return $"Number: {ContNumber}, Weight: {ContWeight}kg, Capacity: {ContCapacity}kL, Size: {ContSize}";
            }

        }

        //This function will validate the weight input.
        private bool ValidateWeight(string input, out int weight)
        {
            weight = 0 ;
            //Try to convert the input text to an integer value, if it fails return false.
            if (!int.TryParse(input, out weight))
            {
                // In future try to combine message boxes errors.
                MessageBox.Show("Please enter a valid WHOLE number for container weight");
                return false ;
            }
            //Checks if the weight range is valid
            // || is the OR operator in C and C#

            if (weight < 500 || weight > 10000)
            {
                // In future try to combine message boxes errors.
                MessageBox.Show("Weight must be between 500 and 10,000kg to be accepted.");
                return false;
            }
            return true;
        }
        private bool ValidateCapacity(string input, out double capacity)
        {
            capacity = 0 ;
            //Tries to convert to a double value
            if (!double.TryParse(input, out capacity))
            {
                // In future try to combine message boxes errors.
                MessageBox.Show("Please enter a valid Decimal number please.");
                return false;
            }
            if (capacity < 0 || capacity > 70)
            {
                // In future try to combine message boxes errors.
                MessageBox.Show("Capacity must be between 0 and 70kg to be accepted.");
                return false;
            }

            return true ;
        }
        private bool ValidateContainerNumber(string input, out string ErrorMessage)
        {
            ErrorMessage = "" ;

            //Check the length of the number.
            if(input.Length != 11)
            {
                ErrorMessage = "Error, number must be 11 characters";
                return false ;
            }

            //Check if its unique.
            foreach (var item in ContainerListBox1.Items)
            {
                if (item is ShippingContainer container)
                {
                    if (container.ContNumber == input)
                    {
                        ErrorMessage = "Error, that item already Exists";
                        return false;
                    }
                }
            }
            return true;
        }
        private void AddContainerButton_Click(object sender, EventArgs e)
        {
            /* This function serves to add items to the list.
             * When the button is clicked it will be added to the list of items.
             * Items are added from the text boxes and attempted to be converted to their values.
             * 
             */

            //Read the inputs from the text boxes.
            string ContNum = ContainerNumberTxtBox.Text;
            string numberError;
            string ContWeightInput = ContainerWeightTxtBox.Text; //input for our checker
            string ContCapacityInput = ContainerCapacityTxtBox.Text;
            // string ContNumInput = "defaultnumber"; Old way of doing this.

            int ContWeight = 0; // This will be the output variable for our checker
            double ContCapacity = 0; // This too!

            if (!ValidateContainerNumber(ContNum, out numberError))
            {
                MessageBox.Show(numberError, "Container Number Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //This will validate if our weight value is acceptable
            if (!ValidateWeight(ContWeightInput, out ContWeight))
            {
                //Stop running code if failed
                return;
            }
            //This will validate if our Capacity value is acceptable
            if (!ValidateCapacity(ContCapacityInput, out ContCapacity))
            {
                //Stop running code if failed
                return;
            }

            //Creates variable size for the shipping container to use locally.
            ShippingContainer.ContainerSize Contsize = ShippingContainer.ContainerSize.Twentyfeet;

            //Read numerical input from textbox, this works by trying to phrase the values i give it as int and double respectively.

            int.TryParse(ContainerWeightTxtBox.Text, out ContWeight); // Not sure if i need this anymore

            double.TryParse(ContainerCapacityTxtBox.Text,out ContCapacity); // Hello.

            if (TwentyFCheckBox.Checked)
            {
                Contsize = ShippingContainer.ContainerSize.Twentyfeet;
            }
            else if (FourtyFCheckBox.Checked)
            {
                Contsize = ContainerSize.Fortyfeet;
            }

            //Create a new container object, the enum is used like this: 'ContainerSize.Twentyfeet' this sets it to a twenty footer.
            ShippingContainer new_Container = new ShippingContainer(ContNum, ContWeight, ContCapacity, Contsize);

            // List boxes work by first by specifying 'Items', then 'Add' or any other function next.
            ContainerListBox1.Items.Add(new_Container);

            // Clear the inputs after adding
            ContainerNumberTxtBox.Clear();
            ContainerWeightTxtBox.Clear();
            ContainerCapacityTxtBox.Clear();
            TwentyFCheckBox.Checked = false;
            FourtyFCheckBox.Checked = false;
        }

        //Removes the selected item from the list of items
        private void RemoveContainerButton_Click(object sender, EventArgs e)
        {
            if (ContainerListBox1.SelectedItem != null)
            {
                //This is the fancy version of the yes and no message box. If you select yes it will remove the selected item.
                var result = MessageBox.Show("Are you sure you want to remove this container?", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //This line removes the selected item from the list
                    ContainerListBox1.Items.Remove(ContainerListBox1.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Please select a container to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Edit the selected item by bringing it back to the text boxes
        private void EditContainerButton_Click(object sender, EventArgs e)
        {
            if(ContainerListBox1.SelectedItem is ShippingContainer selectedContainer)
            {
                //Bring back to text boxes
                ContainerNumberTxtBox.Text = selectedContainer.ContNumber;
                ContainerWeightTxtBox.Text = selectedContainer.ContWeight.ToString();
                ContainerCapacityTxtBox.Text = selectedContainer.ContCapacity.ToString();

                if (selectedContainer.ContSize == ShippingContainer.ContainerSize.Twentyfeet)
                {
                    TwentyFCheckBox.Checked = true;
                    FourtyFCheckBox.Checked = false;
                }
                else
                {
                    TwentyFCheckBox.Checked = false;
                    FourtyFCheckBox.Checked = true;
                }

                //Remove item from the list of items so it can be re-added later
                ContainerListBox1.Items.Remove(selectedContainer);



            }
            else
            {
                MessageBox.Show("Please select a container to edit");
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
