using System;
using System.Collections.Generic;
using System.Text;
using System.Resources;
using System.Configuration;

using log4net;
using log4net.Config;

/*
 * The purpose of this class is to load up configuration information from a resource file and make 
 * configuration information available to classes that require it. 
 * Information such as the database type, location, name, IP, database schema, username and password will be managed
 * by the ConfigurationManager.
 */

namespace AutopatchNET.dotnet.com.tacitknowledge.util.migration.ADO.conf
{
    class MigrationConfigurationManager
    {

        #region Members
        /*
         * Logger
         */ 
        private static ILog log;

        /*
         * Database configuration for checking PatchTable
         */ 
        private DBConfiguration dbConfig;

        /*
         * MigrationConfiguration
         */
        private MigrationConfiguration migrationConfig;

        private ConfigurationFactory configFactory;

        #endregion

        #region Methods
        /*
         * Public constructor. Will load up the information from the resource
         * file if it hasn't been loaded yet. If it has been loaded, it will 
         */
        public MigrationConfigurationManager()
        {
             configFactory = new ConfigurationFactory();
        }
        /*
         * This method returns the MigrationConfiguration object
         */ 
        public MigrationConfiguration getMigrationConfiguration()
        {

              
                    
                    return migrationConfig = configFactory.MigrationConfiguration;
               

        }

        /// <summary>
        /// This method obtains the DBConfiguration object throught he ConfigurationFactory
        /// </summary>
        public DBConfiguration getDBConfiguration()
        {

          
                return configFactory.DbConfiguration;
           

        }


        static MigrationConfigurationManager()
        {
            //Get Logger
            log = LogManager.GetLogger(typeof(MigrationConfigurationManager));
    
        }

        #endregion





    }
}