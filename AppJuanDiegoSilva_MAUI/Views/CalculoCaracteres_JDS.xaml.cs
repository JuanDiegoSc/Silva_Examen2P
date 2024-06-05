namespace AppJuanDiegoSilva_MAUI.Views;

public partial class CalculoCaracteres_JDS : ContentPage
{
    public CalculoCaracteres_JDS()
    {
        InitializeComponent();
    }

    private void Limpiar_JDS(object sender, EventArgs e)
    {
        cadena_JDS.Text = string.Empty;
        numeros_JDS.Text = string.Empty;
        letras_JDS.Text = string.Empty;
        vocales_JDS.Text = string.Empty;
        mayusculas_JDS.Text = string.Empty;
        minusculas_JDS.Text = string.Empty;
        total_JDS.Text = string.Empty;
    }

    private void Calcular_JDS(object sender, EventArgs e)
    {
        string input = cadena_JDS.Text;

        int numeros_JD = CalculoNumeros_JDS(input);
        int letras_JD = CalculoLetras_JDS(input);
        int vocales_JD = CalculoVocales_JDS(input);
        int mayusculas_JD = CalculoMayusculas_JDS(input);
        int minusculas_JD = CalculoMinusculas_JDS(input);
        int total_JD = input.Length;

        numeros_JDS.Text = $"Números: {numeros_JD}";
        letras_JDS.Text = $"Letras: {letras_JD}";
        vocales_JDS.Text = $"Vocales: {vocales_JD}";
        mayusculas_JDS.Text = $"Mayúsculas: {mayusculas_JD}";
        minusculas_JDS.Text = $"Minúsculas: {minusculas_JD}";
        total_JDS.Text = $"Total: {total_JD}";
    }

    private int CalculoNumeros_JDS(string input)
    {
        int cont = 0;

        foreach (char caracter in input)
        {
            if (char.IsDigit(caracter))
            {
                cont++;
            }
        }

        return cont;
    }

    private int CalculoLetras_JDS(string input)
    {
        int cont = 0;

        foreach (char caracter in input)
        {
            if (char.IsLetter(caracter))
            {
                cont++;
            }
        }

        return cont;
    }

    private int CalculoVocales_JDS(string input)
    {
        int c = 0;

        foreach (char caracter in input)
        {
            if (caracter == 'a' || caracter == 'A')
            {
                c++;
            }
            else if (caracter == 'e' || caracter == 'E')
            {
                c++;
            }
            else if (caracter == 'i' || caracter == 'I')
            {
                c++;
            }
            else if (caracter == 'o' || caracter == 'O')
            {
                c++;
            }
            else if (caracter == 'u' || caracter == 'U')
            {
                c++;
            }

        }

        return c;
    }

    private int CalculoMayusculas_JDS(string input)
    {
        int cont = 0;

        foreach (char caracter in input)
        {
            if (char.IsUpper(caracter))
            {
                cont++;
            }
        }

        return cont;
    }


    private int CalculoMinusculas_JDS(string input)
    {
        int cont = 0;

        foreach (char caracter in input)
        {
            if (char.IsLower(caracter))
            {
                cont++;
            }
        }

        return cont;
    }
}