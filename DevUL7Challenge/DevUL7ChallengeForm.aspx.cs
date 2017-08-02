using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevUL7Challenge
{
	public partial class DevUL7ChallengeForm : System.Web.UI.Page
	{
		protected void page_load(object sender, EventArgs e)
		{   
		}
		
		protected void groundRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			Calculate();
		}

		protected void airRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			Calculate();
		}

		protected void nextDayRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			Calculate();
		}

		protected void wTextBox_TextChanged(object sender, EventArgs e)
		{
			Calculate();
		}

		protected void hTextBox_TextChanged(object sender, EventArgs e)
		{
			Calculate();
		}

		protected void lTextBox_TextChanged(object sender, EventArgs e)
		{
			Calculate();
		}

		//protected void handlechange(object sender, EventArgs e)
		//{
		//	Calculate();
		//}

			private void Calculate()
		{
			// throw new NotImplementedException();
			/*
			// Global OPTIONAL int dimension variables
			int width = int.Parse(wTextBox.Text);
			int height = int.Parse(hTextBox.Text);
			int length = int.Parse(lTextBox.Text);
			// Global REQUIRED int rate variable
			double rate = 0.0;
			*/

			// check if values exist
			if (!valuesExist()) return;
			// determine volume
			int volume = 0;
			if (!tryGetVolume(out volume)) return;
			// what is multiplier?
			double multiplier = getMultiplier();
			// determine cost
			double cost = volume * multiplier;
			// show user
			resultLabel.Text = String.Format("Your parcel will cost {0:C} to ship.", cost);
		}
		private bool valuesExist()
		{
			if (!airRadioButton.Checked && !groundRadioButton.Checked && !nextDayRadioButton.Checked)
				return false;
			if (wTextBox.Text.Trim().Length == 0 || hTextBox.Text.Trim().Length == 0)
				return false;
			return true;
		}
		private bool tryGetVolume(out int volume)
		{ //throw new NotImplementedException();
			volume = 0;
			int width = 0;
			int height = 0;
			int length = 0;
			if (!int.TryParse(wTextBox.Text.Trim(), out width))
				return false;
			if (!int.TryParse(hTextBox.Text.Trim(), out height))
				return false;
			if (!int.TryParse(lTextBox.Text.Trim(), out length)) length = 1;
			volume = width * height * length;
			return true;
		}

		private double getMultiplier()
		{
			if (groundRadioButton.Checked)
				return .15;
			else if (airRadioButton.Checked)
				return .25;
			else
				return .45;
		}
	}
}