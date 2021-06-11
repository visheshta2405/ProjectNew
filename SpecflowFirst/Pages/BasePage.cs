namespace SpecflowFirst
{
    public static class BasePage <T> where T : class
    {
      // implement generics on this page

        //public T As<T>() where T : BasePage
        //{
        //    return (T) this;
        //}

        public static T Page { get; set; }

        //public LandingPage landingPage { get; set; }

        //public LoginPage loginPage { get; set; }

    }
}
