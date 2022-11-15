namespace UserDirectory.Domain.Models.Dtos
{
    public class CustomerDto
    {
        public string? first_name { get; set; }
        public string? last_name { get; set; }
        public string? date_of_birth { get; set; }
        public string? email_address { get; set; }
        public string? address { get; set; }
        public string? city { get; set; }
        public string? country { get; set; }
        public string? zip_code { get; set; }
    }
}
