using System;
using Plugin.GoToSettings.Abstractions;

namespace Plugin.GoToSettings
{
  
    public class GoToSettings
    {
    
        public static Lazy<IGoToSettings> implementation = new Lazy<IGoToSettings>(CreateImplementation, System.Threading.LazyThreadSafetyMode.PublicationOnly);

        public static void Go()
        {         
            GetImplementation().Go();
        }

        public static IGoToSettings CreateImplementation()
        {
            
            #if PORTABLE
                return null;
            #else
			    return new GoToSettingsImplementation();
            #endif

		}

		public static IGoToSettings GetImplementation()
        {
            
            var implementationValue = implementation.Value;
            if (implementationValue.Equals(null))
            {                
                throw new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");
	        }

            return implementationValue;

        }

    }

}