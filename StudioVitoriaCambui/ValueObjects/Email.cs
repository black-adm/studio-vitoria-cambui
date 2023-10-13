namespace StudioVitoriaCambui.ValueObjects
{
    public class Email
    {
        private string Address { get; }

        public Email(string address)
        {
            const string validation = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (string.IsNullOrWhiteSpace(address))
            {
                throw new Exception("O campo email não pode ser vazio!");
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(address, validation))
            {
                throw new Exception("O formato do email é inválido!");
            }

            Address = address;
        }
    }
}