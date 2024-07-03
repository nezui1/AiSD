using Microsoft.Extensions.Logging;
using Serilog.Core;

namespace WinFormsApp7;


public partial class Form1 : Form
{
    private readonly ILogger _logger;
    public Form1(ILogger<Form1> logger)
    {
        InitializeComponent();

        _logger = logger;
    }

    private void buttonStart_Click(object sender, EventArgs e)
    {
        try
        {
            _logger.LogInformation("Вычисление S");
            double x = (double)numericUpDownX.Value;
            textBoxY.Text = (0.5 * Math.Log(x)).ToString("F3");
            _logger.LogInformation("Y вычислилось");
            double result = 0;
            for (double i = 1; i <= 10; i+=2)
            {
                result += (1.0 / i) * Math.Pow((x - 1) / (x + 1), i);
                _logger.LogInformation("Новый результат : " + result.ToString("F3"));
            }
            _logger.LogInformation("Ответ : " + result.ToString("F3"));
            textBoxX.Text = result.ToString("F3");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
            MessageBox.Show(ex.Message);
        }
    }
}
