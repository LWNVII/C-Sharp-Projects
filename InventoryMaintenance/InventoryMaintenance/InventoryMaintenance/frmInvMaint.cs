using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmInvMaint : Form
	{
		public frmInvMaint()
		{
			InitializeComponent();
		}

		// Statementthat declares the list of items.
		private List<InvItem> invItems = null;

		private void frmInvMaint_Load(object sender, EventArgs e)
		{
			// Add a statement here that gets the list of items.
			invItems = InvItemDB.GetItems();
			FillItemListBox();
		}

		private void FillItemListBox()
		{
			lstItems.Items.Clear();
            foreach (InvItem s in invItems)
            {
                lstItems.Items.Add(s.GetDisplayText());
            }
        }

		private void btnAdd_Click(object sender, EventArgs e)
		{
            // Creates an instance of the New Item form
			frmNewItem newInvMainForm = new frmNewItem();
			// and then gets a new item from that form.
			InvItem invItem = newInvMainForm.GetNewItem();

			// Checks input is != null and adds to list if true
			if (invItems != null)
			{
				invItems.Add(invItem);
				InvItemDB.SaveItems(invItems);
				FillItemListBox();
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int i = lstItems.SelectedIndex;
			if (i != -1)
			{
				// Gets information of inventory item from invItems list and assigns the information to class variable of type InvItem
				InvItem invItem = (InvItem)invItems[i];
				// Displays confirmation message.
				string message = "Confirm deletion of : " + invItem.Description + ".";
				// Displays button options to confirm deletion.
				DialogResult button = MessageBox.Show(message, "Confirm Deletion", MessageBoxButtons.YesNo);

				// If user selected confirms, then the item is removed from the list and the list is updated.
				if (button == DialogResult.Yes)
				{
					invItems.Remove(invItem);
					InvItemDB.SaveItems(invItems);
					FillItemListBox();
				}
            }
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}