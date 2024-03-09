namespace Final_Project_2024.Responses
{
    public class CustomResponses
    {
        public record RegistationResponses(bool Flag = false, string Message= null!);
        public record LoginResponses(bool Flag = false, string Message = null!, string JWTToken = null!);
    }
}
