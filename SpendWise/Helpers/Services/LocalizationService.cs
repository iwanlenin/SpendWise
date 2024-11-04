using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace SpendWise.Helpers.Services
{
    public static class LocalizationService
    {
        /// <summary>
        /// Initializes a new instance of the ResourceManager class for retrieving resources.
        /// </summary>
        public static ResourceManager ResourceManager { get; } = new ResourceManager(nameof(SpendWise.Resources.Strings.AppResources), typeof(LocalizationService).Assembly);

        /// <summary>
        /// Gets or sets the current culture for localization.
        /// </summary>
        public static CultureInfo CurrentCulture { get; set; } = CultureInfo.CurrentCulture;

        /// <summary>
        /// Retrieves the localized string associated with the specified key.
        /// </summary>
        /// <param name="key">The key for the desired string. Can't be null</param>
        /// <returns>
        /// The localized string corresponding to the provided key and the current culture.
        /// If the key is not found in the culture-specific resource file, it falls back to the default resource.
        /// </returns>
        /// <example>
        /// If the CurrentCulture is set to "es-ES" and a resource file named AppResources.es-ES.resx exists,
        /// calling GetString("WelcomeMessage") will return the Spanish version of the welcome message.
        /// </example>
        public static string GetString(string key) 
        {
            if (string.IsNullOrEmpty(key)) 
            {
                throw new ArgumentNullException(nameof(key), "The resource key cannot be null or empty.");
            }
            

            return ResourceManager.GetString(key, CurrentCulture);
        }
    }
}
