namespace Movies
{
    class VMLocator
    {
        public static MainViewModel MainVM { get; } = new MainViewModel();
        public static LogInViewModel LogInVM { get; } = new LogInViewModel();
        public static RegistrationViewModel RegistrationVM { get; } = new RegistrationViewModel();
        public static FilmDescriptionViewModel FilmDescriptionVM { get; } = new FilmDescriptionViewModel();


    }
}
