namespace StudioVitoriaCambui.ValueObjects;

public class Phone
{
    public string Contact { get; }

    public Phone(string contact)
    {
        const string validation = @"^\d{1,11}$";
        
        if (string.IsNullOrWhiteSpace(contact))
        {
            throw new Exception("O campo telefone não pode ser vazio!");
        }

        if (!System.Text.RegularExpressions.Regex.IsMatch(contact, validation))
        {
            throw new Exception("O formato do número do seu celular é inválido!");
        }

        Contact = contact;
    }
}