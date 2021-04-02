//Namespace System para que seja possível utilizar, sem a instanciação da pasta das extensões (o namespace utilizado, deve ser o do tipo Extension: nesse caso, era o SYSTEM.DateTime) )
namespace System
{
    //Classe static
    static class DateTimeExtension
    {
        //Metodo static
        //O parâmetro é o próprio objeto (this T obj)
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalSeconds < 60)
            {
                return $"{Math.Round(duration.TotalSeconds)} seconds";
            } else if (duration.TotalMinutes < 60)
            {
                return $"{Math.Round(duration.TotalMinutes)} minutes";
            } else if (duration.TotalHours < 24)
            {
                return $"{Math.Round(duration.TotalHours)} hours";
            } else
            {
                return $"{Math.Round(duration.TotalDays)} days";
            }
        }
    }
}
