using System;

namespace IronCarnation.Engine
{
    public class EngineRunner
    {
        #region static members
        private static EngineRunner m_Instance;
        #endregion

        #region static properties
        public static EngineRunner Instance
        {
            get
            {
                if(m_Instance == null)
                {
                    m_Instance = new  EngineRunner();
                }

                return (m_Instance);
            }
        }
        #endregion

        #region public instance methods
        public void RunAll(string modelConfigRootFolder)
        {

        }
        #endregion

        private EngineRunner(){}
    }
}
