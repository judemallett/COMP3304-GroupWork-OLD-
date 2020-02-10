using System;
using System.Text;

public class TextBoxStorage
{

    string _defaultText;
    string _userText;

    public TextBoxStorage()
	{
        _defaultText = "Enter your note here...";
    }

    public void LoadText(System.Windows.Forms.TextBox pTextBox)
    {
        pTextBox.Text = _defaultText;
        pTextBox.Select(0, 0);
    }

    public void Click(System.Windows.Forms.TextBox pTextBox)
    {
        if (pTextBox.Text == _defaultText)
        {
            pTextBox.Text = "";
        }

    }

    public void TextChanged(System.Windows.Forms.TextBox pTextBox)
    {
        _userText = pTextBox.Text;
    }
}
