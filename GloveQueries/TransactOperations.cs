
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GloveClasses;
using GloveDatabase;
using GloveInterfaces;

namespace GloveQueries
{

    # pragma warning disable CS8618, CS8604, IDE0090
    public class TransactOperations
    {

        private readonly static MySQLiteConnection mSql = new MySQLiteConnection();
        private readonly static SQLiteConnection sCon = mSql.GetConnection();
        private static SQLiteCommand mCommand;
        private static SQLiteDataReader mDataReader;

        public static List<int> RecoverSesions(int patientId)
        {
            string query = "SELECT SesId FROM Session WHERE SesPatientId = " + patientId + " ORDER BY SesId DESC";
            List<int> sessionsId = new List<int>();
            sCon.Open();
            mCommand = new SQLiteCommand(query, sCon);
            try
            {
                mDataReader = mCommand.ExecuteReader();
                while (mDataReader.Read())
                {
                    sessionsId.Add(Convert.ToInt32(mDataReader[0]));
                }
                mDataReader.Close();
                return sessionsId;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sCon.Close();
            }
            return sessionsId;
        }

        public static double RecoverMetersOfSession(int sesId)
        {
            string query = "SELECT SesMeters FROM Session WHERE SesId = " + sesId;
            double meters = -1;
            sCon.Open();
            mCommand = new SQLiteCommand(query, sCon);
            try
            {
                mDataReader = mCommand.ExecuteReader();
                while (mDataReader.Read())
                {
                    meters = Convert.ToDouble(mDataReader[0]);
                }
                mDataReader.Close();
                return meters;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sCon.Close();
            }
            return meters;
        }

        public static double RecoverAverageMeters(int patientId)
        {
            string query = "SELECT AVG(SesMeters) FROM Session WHERE SesPatientId = " + patientId;
            double metersAvg = -1;
            sCon.Open();
            mCommand = new SQLiteCommand(query, sCon);
            try
            {
                mDataReader = mCommand.ExecuteReader();
                while (mDataReader.Read())
                {
                    metersAvg = Math.Round(Convert.ToDouble(mDataReader[0]));
                }
                mDataReader.Close();
                return metersAvg;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sCon.Close();
            }
            return metersAvg;
        }

        public static double RecoverCoinsOfSession(int sesId)
        {
            string query = "SELECT SesCoins FROM Session WHERE SesId = " + sesId;
            double coins = -1;
            sCon.Open();
            mCommand = new SQLiteCommand(query, sCon);
            try
            {
                mDataReader = mCommand.ExecuteReader();
                while (mDataReader.Read())
                {
                    coins = Convert.ToDouble(mDataReader[0]);
                }
                mDataReader.Close();
                return coins;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sCon.Close();
            }
            return coins;
        }

        public static double RecoverAverageCoins(int patientId)
        {
            string query = "SELECT AVG(SesCoins) FROM Session WHERE SesPatientId = " + patientId;
            double coinsAvg = -1;
            sCon.Open();
            mCommand = new SQLiteCommand(query, sCon);
            try
            {
                mDataReader = mCommand.ExecuteReader();
                while (mDataReader.Read())
                {
                    coinsAvg = Math.Round(Convert.ToDouble(mDataReader[0]));
                }
                mDataReader.Close();
                return coinsAvg;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sCon.Close();
            }
            return coinsAvg;
        }


        public static double RecoverAngleOfSession(int sessionId, int motionType)
        {
            List<string> fingersAngle = ["Thumb", "Index", "Middle", "Ring", "Pinky"];
            string query = "SELECT ROUND(AVG(Han" + fingersAngle[motionType - 1] + "Angle), 2) FROM HandMotion WHERE HanSessionId = " + sessionId + " AND HanMotionType = " + motionType;
            double angleAvg = -1;
            sCon.Open();
            mCommand = new SQLiteCommand(query, sCon);
            try
            {
                mDataReader = mCommand.ExecuteReader();
                while (mDataReader.Read())
                {
                    angleAvg = Math.Round(Convert.ToDouble(mDataReader[0]));
                }
                mDataReader.Close();
                return angleAvg;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sCon.Close();
            }
            return angleAvg;
        }

    }

}
