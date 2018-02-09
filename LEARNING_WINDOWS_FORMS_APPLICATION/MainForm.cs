namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void TextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			// کاراکتری که کاربر وارد کرده است
			//switch (e.KeyChar)
			//{
			//	case '0':
			//	case '1':
			//	case '2':
			//	case '3':
			//	case '4':
			//	case '5':
			//	case '6':
			//	case '7':
			//	case '8':
			//	case '9':
			//	{
			//		break;
			//	}

			//	default:
			//	{
			//		// شتر دیدی ندیدی - بی خیال شو
			//		e.Handled = true;
			//		break;
			//	}
			//}



			// کد اسکی کاراکتری که کاربر وارد کرده است
			//if ((e.KeyChar < '0') || (e.KeyChar > '9'))
			//{
			//	e.Handled = true;
			//}



			//if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) == false)
			//{
			//	e.Handled = true;
			//}



			if ((((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == 8)) == false)
			{
				e.Handled = true;
			}
		}
	}
}
