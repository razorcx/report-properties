using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Model.UI;

namespace ReportProperties
{
	public partial class ReportPropertiesForm : Form
	{
		private Part _part;

		public ReportPropertiesForm()
		{
			InitializeComponent();

			richTextBoxString.Text = @"NAME 
PROFILE
PART_POS 
MATERIAL 
TOP_LEVEL";
			richTextBoxInt.Text = @"ID 
PHASE";
			richTextBoxDouble.Text = @"LENGTH 
WEIGHT 
AREA";
		}

		private void buttonString_Click(object sender, EventArgs e)
		{
			if (_part == null) return;
			GetStringProperties();
		}

		private void buttonInt_Click(object sender, EventArgs e)
		{
			if (_part == null) return;
			GetIntProperties();
		}

		private void buttonDouble_Click(object sender, EventArgs e)
		{
			if (_part == null) return;
			GetDoubleProperties();
		}

		private void buttonSelectPart_Click(object sender, EventArgs e)
		{
			try
			{
				var picker = new Picker();
				_part = picker.PickObject(Picker.PickObjectEnum.PICK_ONE_PART) as Part;
				textBoxPart.Text = _part.Identifier.ID.ToString();

				GetStringProperties();
				GetIntProperties();
				GetDoubleProperties();
			}
			catch (Exception ex)
			{
				
			}
		}

		private void GetStringProperties()
		{
			var stringProperties = richTextBoxString.Text.Split('\n');
			var arrayList = new ArrayList();
			foreach (var property in stringProperties)
			{
				arrayList.Add(property.TrimEnd(' '));
			}
			var properties = new Hashtable();
			_part.GetStringReportProperties(arrayList, ref properties);
			listBoxString.DataSource = properties.Values.OfType<string>().ToList();
		}

		private void GetIntProperties()
		{
			var intProperties = richTextBoxInt.Text.Split('\n');
			var arrayList = new ArrayList();
			foreach (var property in intProperties)
			{
				arrayList.Add(property.TrimEnd(' '));
			}
			var properties = new Hashtable();
			_part.GetIntegerReportProperties(arrayList, ref properties);
			listBoxInt.DataSource = properties.Values.OfType<int>().ToList();
		}

		private void GetDoubleProperties()
		{
			var doubleProperties = richTextBoxDouble.Text.Split('\n');
			var arrayList = new ArrayList();
			foreach (var property in doubleProperties)
			{
				arrayList.Add(property.TrimEnd(' '));
			}
			var properties = new Hashtable();
			_part.GetDoubleReportProperties(arrayList, ref properties);
			listBoxDouble.DataSource = properties.Values.OfType<double>().ToList();
		}
	}
}
