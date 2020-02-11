namespace PocGraphicQL
{
    public class Response
    {
        private bool _sucess = true;

        public bool IsSucess() => _sucess;

        public void Fail() => _sucess = false;

        public object Value;

        public Response(object value) => Value = value;
    }
}
