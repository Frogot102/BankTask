using System;
using System.Collections.Generic;
using Npgsql;
using BankTask.Models;

namespace BankTask.Data
{
    public static class DbAccess
    {
        private const string ConnectionString = "Host=localhost;Port=5432;Database=BankTaskDb;Username=postgres;Password=123";

        public static List<Client> GetClients()
        {
            var clients = new List<Client>();
            using var conn = new NpgsqlConnection(ConnectionString);
            conn.Open();
            using var cmd = new NpgsqlCommand(@"
        SELECT ""ID"", ""CLIENT_ACC"", ""DATE_BEGIN"", ""DATE_END"", ""IKUSNUM"",
               ""AGGREMENT_NUM"", ""AGGREMENT_DATE"", ""ACC_N068"", ""ACC_47426"",
               ""IS_ACTIVE"", ""CREATE_USER"", ""CREATE_DATE"", ""UPDATE_USER"",
               ""UPDATE_DATE"", ""NOTE"", ""ERR_MESSAGE"", ""CLIENT_ACC_DOP""
        FROM ""AVERS_DWH_NSO_CLIENT""", conn);
            using var reader = cmd.ExecuteReader();

            // Получаем индексы столбцов один раз, чтобы не вызывать GetOrdinal на каждой итерации
            int idIndex = reader.GetOrdinal("ID");
            int clientAccIndex = reader.GetOrdinal("CLIENT_ACC");
            int dateBeginIndex = reader.GetOrdinal("DATE_BEGIN");
            int dateEndIndex = reader.GetOrdinal("DATE_END");
            int ikusnumIndex = reader.GetOrdinal("IKUSNUM");
            int agreementNumIndex = reader.GetOrdinal("AGGREMENT_NUM");
            int agreementDateIndex = reader.GetOrdinal("AGGREMENT_DATE");
            int accN068Index = reader.GetOrdinal("ACC_N068");
            int acc47426Index = reader.GetOrdinal("ACC_47426");
            int isActiveIndex = reader.GetOrdinal("IS_ACTIVE");
            int createUserIndex = reader.GetOrdinal("CREATE_USER");
            int createDateIndex = reader.GetOrdinal("CREATE_DATE");
            int updateUserIndex = reader.GetOrdinal("UPDATE_USER");
            int updateDateIndex = reader.GetOrdinal("UPDATE_DATE");
            int noteIndex = reader.GetOrdinal("NOTE");
            int errMessageIndex = reader.GetOrdinal("ERR_MESSAGE");
            int clientAccDopIndex = reader.GetOrdinal("CLIENT_ACC_DOP");

            while (reader.Read())
            {
                clients.Add(new Client
                {
                    ID = reader.GetInt32(idIndex),
                    CLIENT_ACC = reader.GetString(clientAccIndex),
                    DATE_BEGIN = reader.GetDateTime(dateBeginIndex),
                    DATE_END = reader.IsDBNull(dateEndIndex) ? (DateTime?)null : reader.GetDateTime(dateEndIndex),
                    IKUSNUM = reader.GetInt32(ikusnumIndex),
                    AGGREMENT_NUM = reader.IsDBNull(agreementNumIndex) ? null : reader.GetString(agreementNumIndex),
                    AGGREMENT_DATE = reader.IsDBNull(agreementDateIndex) ? (DateTime?)null : reader.GetDateTime(agreementDateIndex),
                    ACC_N068 = reader.IsDBNull(accN068Index) ? null : reader.GetString(accN068Index),
                    ACC_47426 = reader.IsDBNull(acc47426Index) ? null : reader.GetString(acc47426Index),
                    IS_ACTIVE = reader.GetBoolean(isActiveIndex),
                    CREATE_USER = reader.GetString(createUserIndex),
                    CREATE_DATE = reader.GetDateTime(createDateIndex),
                    UPDATE_USER = reader.IsDBNull(updateUserIndex) ? null : reader.GetString(updateUserIndex),
                    UPDATE_DATE = reader.IsDBNull(updateDateIndex) ? (DateTime?)null : reader.GetDateTime(updateDateIndex),
                    NOTE = reader.IsDBNull(noteIndex) ? null : reader.GetString(noteIndex),
                    ERR_MESSAGE = reader.IsDBNull(errMessageIndex) ? null : reader.GetString(errMessageIndex),
                    CLIENT_ACC_DOP = reader.IsDBNull(clientAccDopIndex) ? null : reader.GetString(clientAccDopIndex)
                });
            }
            return clients;
        }
        // Добавить клиента
        public static void AddClient(Client client)
        {
            using var conn = new NpgsqlConnection(ConnectionString);
            conn.Open();
            using var cmd = new NpgsqlCommand(@"
        INSERT INTO ""AVERS_DWH_NSO_CLIENT"" 
        (""CLIENT_ACC"", ""DATE_BEGIN"", ""DATE_END"", ""IKUSNUM"", ""AGGREMENT_NUM"",
         ""AGGREMENT_DATE"", ""ACC_N068"", ""ACC_47426"", ""IS_ACTIVE"", ""CREATE_USER"",
         ""CREATE_DATE"", ""UPDATE_USER"", ""UPDATE_DATE"", ""NOTE"", ""ERR_MESSAGE"", ""CLIENT_ACC_DOP"")
        VALUES (@CLIENT_ACC, @DATE_BEGIN, @DATE_END, @IKUSNUM, @AGGREMENT_NUM,
                @AGGREMENT_DATE, @ACC_N068, @ACC_47426, @IS_ACTIVE, @CREATE_USER,
                @CREATE_DATE, @UPDATE_USER, @UPDATE_DATE, @NOTE, @ERR_MESSAGE, @CLIENT_ACC_DOP)",
                conn);

            cmd.Parameters.Add("@CLIENT_ACC", NpgsqlTypes.NpgsqlDbType.Varchar).Value = client.CLIENT_ACC;
            cmd.Parameters.Add("@DATE_BEGIN", NpgsqlTypes.NpgsqlDbType.Date).Value = client.DATE_BEGIN;
            cmd.Parameters.Add("@DATE_END", NpgsqlTypes.NpgsqlDbType.Date).Value = client.DATE_END ?? (object)DBNull.Value;
            cmd.Parameters.Add("@IKUSNUM", NpgsqlTypes.NpgsqlDbType.Integer).Value = client.IKUSNUM;
            cmd.Parameters.Add("@AGGREMENT_NUM", NpgsqlTypes.NpgsqlDbType.Varchar).Value = client.AGGREMENT_NUM ?? (object)DBNull.Value;
            cmd.Parameters.Add("@AGGREMENT_DATE", NpgsqlTypes.NpgsqlDbType.Date).Value = client.AGGREMENT_DATE ?? (object)DBNull.Value;
            cmd.Parameters.Add("@ACC_N068", NpgsqlTypes.NpgsqlDbType.Varchar).Value = client.ACC_N068 ?? (object)DBNull.Value;
            cmd.Parameters.Add("@ACC_47426", NpgsqlTypes.NpgsqlDbType.Varchar).Value = client.ACC_47426 ?? (object)DBNull.Value;
            cmd.Parameters.Add("@IS_ACTIVE", NpgsqlTypes.NpgsqlDbType.Boolean).Value = client.IS_ACTIVE;
            cmd.Parameters.Add("@CREATE_USER", NpgsqlTypes.NpgsqlDbType.Varchar).Value = client.CREATE_USER;
            cmd.Parameters.Add("@CREATE_DATE", NpgsqlTypes.NpgsqlDbType.Date).Value = client.CREATE_DATE;
            cmd.Parameters.Add("@UPDATE_USER", NpgsqlTypes.NpgsqlDbType.Varchar).Value = client.UPDATE_USER ?? (object)DBNull.Value;
            cmd.Parameters.Add("@UPDATE_DATE", NpgsqlTypes.NpgsqlDbType.Date).Value = client.UPDATE_DATE ?? (object)DBNull.Value;
            cmd.Parameters.Add("@NOTE", NpgsqlTypes.NpgsqlDbType.Varchar).Value = client.NOTE ?? (object)DBNull.Value;
            cmd.Parameters.Add("@ERR_MESSAGE", NpgsqlTypes.NpgsqlDbType.Varchar).Value = client.ERR_MESSAGE ?? (object)DBNull.Value;
            cmd.Parameters.Add("@CLIENT_ACC_DOP", NpgsqlTypes.NpgsqlDbType.Varchar).Value = client.CLIENT_ACC_DOP ?? (object)DBNull.Value;

            cmd.ExecuteNonQuery();
        }

        // Обновить клиента
        public static void UpdateClient(Client client)
        {
            using var conn = new NpgsqlConnection(ConnectionString);
            conn.Open();
            using var cmd = new NpgsqlCommand(@"
        UPDATE ""AVERS_DWH_NSO_CLIENT"" SET
            ""CLIENT_ACC"" = @CLIENT_ACC,
            ""DATE_BEGIN"" = @DATE_BEGIN,
            ""DATE_END"" = @DATE_END,
            ""IKUSNUM"" = @IKUSNUM,
            ""AGGREMENT_NUM"" = @AGGREMENT_NUM,
            ""AGGREMENT_DATE"" = @AGGREMENT_DATE,
            ""ACC_N068"" = @ACC_N068,
            ""ACC_47426"" = @ACC_47426,
            ""IS_ACTIVE"" = @IS_ACTIVE,
            ""CREATE_USER"" = @CREATE_USER,
            ""CREATE_DATE"" = @CREATE_DATE,
            ""UPDATE_USER"" = @UPDATE_USER,
            ""UPDATE_DATE"" = @UPDATE_DATE,
            ""NOTE"" = @NOTE,
            ""ERR_MESSAGE"" = @ERR_MESSAGE,
            ""CLIENT_ACC_DOP"" = @CLIENT_ACC_DOP
        WHERE ""ID"" = @ID", conn);

            // Явно добавляем параметры с указанием типа
            cmd.Parameters.Add("@ID", NpgsqlTypes.NpgsqlDbType.Integer).Value = client.ID;
            cmd.Parameters.Add("@CLIENT_ACC", NpgsqlTypes.NpgsqlDbType.Varchar).Value = client.CLIENT_ACC;
            cmd.Parameters.Add("@DATE_BEGIN", NpgsqlTypes.NpgsqlDbType.Date).Value = client.DATE_BEGIN;
            cmd.Parameters.Add("@DATE_END", NpgsqlTypes.NpgsqlDbType.Date).Value = client.DATE_END ?? (object)DBNull.Value;
            cmd.Parameters.Add("@IKUSNUM", NpgsqlTypes.NpgsqlDbType.Integer).Value = client.IKUSNUM;
            cmd.Parameters.Add("@AGGREMENT_NUM", NpgsqlTypes.NpgsqlDbType.Varchar).Value = client.AGGREMENT_NUM ?? (object)DBNull.Value;
            cmd.Parameters.Add("@AGGREMENT_DATE", NpgsqlTypes.NpgsqlDbType.Date).Value = client.AGGREMENT_DATE ?? (object)DBNull.Value;
            cmd.Parameters.Add("@ACC_N068", NpgsqlTypes.NpgsqlDbType.Varchar).Value = client.ACC_N068 ?? (object)DBNull.Value;
            cmd.Parameters.Add("@ACC_47426", NpgsqlTypes.NpgsqlDbType.Varchar).Value = client.ACC_47426 ?? (object)DBNull.Value;
            cmd.Parameters.Add("@IS_ACTIVE", NpgsqlTypes.NpgsqlDbType.Boolean).Value = client.IS_ACTIVE;
            cmd.Parameters.Add("@CREATE_USER", NpgsqlTypes.NpgsqlDbType.Varchar).Value = client.CREATE_USER;
            cmd.Parameters.Add("@CREATE_DATE", NpgsqlTypes.NpgsqlDbType.Date).Value = client.CREATE_DATE;
            cmd.Parameters.Add("@UPDATE_USER", NpgsqlTypes.NpgsqlDbType.Varchar).Value = client.UPDATE_USER ?? (object)DBNull.Value;
            cmd.Parameters.Add("@UPDATE_DATE", NpgsqlTypes.NpgsqlDbType.Date).Value = client.UPDATE_DATE ?? (object)DBNull.Value;
            cmd.Parameters.Add("@NOTE", NpgsqlTypes.NpgsqlDbType.Varchar).Value = client.NOTE ?? (object)DBNull.Value;
            cmd.Parameters.Add("@ERR_MESSAGE", NpgsqlTypes.NpgsqlDbType.Varchar).Value = client.ERR_MESSAGE ?? (object)DBNull.Value;
            cmd.Parameters.Add("@CLIENT_ACC_DOP", NpgsqlTypes.NpgsqlDbType.Varchar).Value = client.CLIENT_ACC_DOP ?? (object)DBNull.Value;

            cmd.ExecuteNonQuery();
        }
        // Удалить клиента
        public static void DeleteClient(int id)
        {
            using var conn = new NpgsqlConnection(ConnectionString);
            conn.Open();
            using var cmd = new NpgsqlCommand(@"DELETE FROM ""AVERS_DWH_NSO_CLIENT"" WHERE ""ID"" = @ID", conn);
            cmd.Parameters.AddWithValue("ID", id);
            cmd.ExecuteNonQuery();
        }
        // Получить все заявки
        public static List<Request> GetRequests()
        {
            var requests = new List<Request>();
            using var conn = new NpgsqlConnection(ConnectionString);
            conn.Open();
            using var cmd = new NpgsqlCommand(@"
        SELECT ""ID"", ""CLIENT_ACC"", ""CREATE_DATE"", ""SUMM"", ""ADDAGGREMENT_NUM"",
               ""PRC_STR"", ""DATE_BEGIN"", ""DATE_END"", ""DAYS_COUNT"", ""PRC_JS_CALC"",
               ""PRC_NUM"", ""DATE_BREAK"", ""IS_ENDED"", ""ADDAGGREMENT_DATE"", ""IKUSNUM"",
               ""CREATE_USER"", ""UPDATE_USER"", ""UPDATE_DATE"", ""NOTE"", ""ERR_MESSAGE"",
               ""NSO_CLIENT_ID""
        FROM ""AVERS_DWH_NSO_REQUESTS""", conn);
            using var reader = cmd.ExecuteReader();

            int idIndex = reader.GetOrdinal("ID");
            int clientAccIndex = reader.GetOrdinal("CLIENT_ACC");
            int createDateIndex = reader.GetOrdinal("CREATE_DATE");
            int summIndex = reader.GetOrdinal("SUMM");
            int addAgreementNumIndex = reader.GetOrdinal("ADDAGGREMENT_NUM");
            int prcStrIndex = reader.GetOrdinal("PRC_STR");
            int dateBeginIndex = reader.GetOrdinal("DATE_BEGIN");
            int dateEndIndex = reader.GetOrdinal("DATE_END");
            int daysCountIndex = reader.GetOrdinal("DAYS_COUNT");
            int prcJsCalcIndex = reader.GetOrdinal("PRC_JS_CALC");
            int prcNumIndex = reader.GetOrdinal("PRC_NUM");
            int dateBreakIndex = reader.GetOrdinal("DATE_BREAK");
            int isEndedIndex = reader.GetOrdinal("IS_ENDED");
            int addAgreementDateIndex = reader.GetOrdinal("ADDAGGREMENT_DATE");
            int ikusnumIndex = reader.GetOrdinal("IKUSNUM");
            int createUserIndex = reader.GetOrdinal("CREATE_USER");
            int updateUserIndex = reader.GetOrdinal("UPDATE_USER");
            int updateDateIndex = reader.GetOrdinal("UPDATE_DATE");
            int noteIndex = reader.GetOrdinal("NOTE");
            int errMessageIndex = reader.GetOrdinal("ERR_MESSAGE");
            int nsoClientIdIndex = reader.GetOrdinal("NSO_CLIENT_ID");

            while (reader.Read())
            {
                requests.Add(new Request
                {
                    ID = reader.GetInt32(idIndex),
                    CLIENT_ACC = reader.GetString(clientAccIndex),
                    CREATE_DATE = reader.GetDateTime(createDateIndex),
                    SUMM = reader.IsDBNull(summIndex) ? null : reader.GetString(summIndex),
                    ADDAGGREMENT_NUM = reader.IsDBNull(addAgreementNumIndex) ? null : reader.GetString(addAgreementNumIndex),
                    PRC_STR = reader.IsDBNull(prcStrIndex) ? null : reader.GetString(prcStrIndex),
                    DATE_BEGIN = reader.GetDateTime(dateBeginIndex),
                    DATE_END = reader.IsDBNull(dateEndIndex) ? (DateTime?)null : reader.GetDateTime(dateEndIndex),
                    DAYS_COUNT = reader.IsDBNull(daysCountIndex) ? null : reader.GetString(daysCountIndex),
                    PRC_JS_CALC = reader.IsDBNull(prcJsCalcIndex) ? (int?)null : reader.GetInt32(prcJsCalcIndex),
                    PRC_NUM = reader.IsDBNull(prcNumIndex) ? (int?)null : reader.GetInt32(prcNumIndex),
                    DATE_BREAK = reader.IsDBNull(dateBreakIndex) ? (DateTime?)null : reader.GetDateTime(dateBreakIndex),
                    IS_ENDED = reader.IsDBNull(isEndedIndex) ? (int?)null : reader.GetInt32(isEndedIndex),
                    ADDAGGREMENT_DATE = reader.IsDBNull(addAgreementDateIndex) ? (DateTime?)null : reader.GetDateTime(addAgreementDateIndex),
                    IKUSNUM = reader.GetInt32(ikusnumIndex),
                    CREATE_USER = reader.IsDBNull(createUserIndex) ? null : reader.GetString(createUserIndex),
                    UPDATE_USER = reader.IsDBNull(updateUserIndex) ? null : reader.GetString(updateUserIndex),
                    UPDATE_DATE = reader.IsDBNull(updateDateIndex) ? (DateTime?)null : reader.GetDateTime(updateDateIndex),
                    NOTE = reader.IsDBNull(noteIndex) ? null : reader.GetString(noteIndex),
                    ERR_MESSAGE = reader.IsDBNull(errMessageIndex) ? null : reader.GetString(errMessageIndex),
                    NSO_CLIENT_ID = reader.GetInt32(nsoClientIdIndex)
                });
            }
            return requests;
        }

        // Добавить заявку

        public static void AddRequest(Request request)
        {
            using var conn = new NpgsqlConnection(ConnectionString);
            conn.Open();
            using var cmd = new NpgsqlCommand(@"
        INSERT INTO ""AVERS_DWH_NSO_REQUESTS"" 
        (""CLIENT_ACC"", ""CREATE_DATE"", ""SUMM"", ""ADDAGGREMENT_NUM"", ""PRC_STR"",
         ""DATE_BEGIN"", ""DATE_END"", ""DAYS_COUNT"", ""PRC_JS_CALC"", ""PRC_NUM"",
         ""DATE_BREAK"", ""IS_ENDED"", ""ADDAGGREMENT_DATE"", ""IKUSNUM"",
         ""CREATE_USER"", ""UPDATE_USER"", ""UPDATE_DATE"", ""NOTE"", ""ERR_MESSAGE"",
         ""NSO_CLIENT_ID"")
        VALUES (@CLIENT_ACC, @CREATE_DATE, @SUMM, @ADDAGGREMENT_NUM, @PRC_STR,
                @DATE_BEGIN, @DATE_END, @DAYS_COUNT, @PRC_JS_CALC, @PRC_NUM,
                @DATE_BREAK, @IS_ENDED, @ADDAGGREMENT_DATE, @IKUSNUM,
                @CREATE_USER, @UPDATE_USER, @UPDATE_DATE, @NOTE, @ERR_MESSAGE,
                @NSO_CLIENT_ID)", conn);

            cmd.Parameters.Add("@CLIENT_ACC", NpgsqlTypes.NpgsqlDbType.Varchar).Value = request.CLIENT_ACC;
            cmd.Parameters.Add("@CREATE_DATE", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = request.CREATE_DATE;
            cmd.Parameters.Add("@SUMM", NpgsqlTypes.NpgsqlDbType.Varchar).Value = request.SUMM ?? (object)DBNull.Value;
            cmd.Parameters.Add("@ADDAGGREMENT_NUM", NpgsqlTypes.NpgsqlDbType.Varchar).Value = request.ADDAGGREMENT_NUM ?? (object)DBNull.Value;
            cmd.Parameters.Add("@PRC_STR", NpgsqlTypes.NpgsqlDbType.Varchar).Value = request.PRC_STR ?? (object)DBNull.Value;
            cmd.Parameters.Add("@DATE_BEGIN", NpgsqlTypes.NpgsqlDbType.Date).Value = request.DATE_BEGIN;
            cmd.Parameters.Add("@DATE_END", NpgsqlTypes.NpgsqlDbType.Date).Value = request.DATE_END ?? (object)DBNull.Value;
            cmd.Parameters.Add("@DAYS_COUNT", NpgsqlTypes.NpgsqlDbType.Varchar).Value = request.DAYS_COUNT ?? (object)DBNull.Value;
            cmd.Parameters.Add("@PRC_JS_CALC", NpgsqlTypes.NpgsqlDbType.Integer).Value = request.PRC_JS_CALC ?? (object)DBNull.Value;
            cmd.Parameters.Add("@PRC_NUM", NpgsqlTypes.NpgsqlDbType.Integer).Value = request.PRC_NUM ?? (object)DBNull.Value;
            cmd.Parameters.Add("@DATE_BREAK", NpgsqlTypes.NpgsqlDbType.Date).Value = request.DATE_BREAK ?? (object)DBNull.Value;
            cmd.Parameters.Add("@IS_ENDED", NpgsqlTypes.NpgsqlDbType.Integer).Value = request.IS_ENDED ?? (object)DBNull.Value;
            cmd.Parameters.Add("@ADDAGGREMENT_DATE", NpgsqlTypes.NpgsqlDbType.Date).Value = request.ADDAGGREMENT_DATE ?? (object)DBNull.Value;
            cmd.Parameters.Add("@IKUSNUM", NpgsqlTypes.NpgsqlDbType.Integer).Value = request.IKUSNUM;
            cmd.Parameters.Add("@CREATE_USER", NpgsqlTypes.NpgsqlDbType.Varchar).Value = request.CREATE_USER ?? (object)DBNull.Value;
            cmd.Parameters.Add("@UPDATE_USER", NpgsqlTypes.NpgsqlDbType.Varchar).Value = request.UPDATE_USER ?? (object)DBNull.Value;
            cmd.Parameters.Add("@UPDATE_DATE", NpgsqlTypes.NpgsqlDbType.Date).Value = request.UPDATE_DATE ?? (object)DBNull.Value;
            cmd.Parameters.Add("@NOTE", NpgsqlTypes.NpgsqlDbType.Varchar).Value = request.NOTE ?? (object)DBNull.Value;
            cmd.Parameters.Add("@ERR_MESSAGE", NpgsqlTypes.NpgsqlDbType.Varchar).Value = request.ERR_MESSAGE ?? (object)DBNull.Value;
            cmd.Parameters.Add("@NSO_CLIENT_ID", NpgsqlTypes.NpgsqlDbType.Integer).Value = request.NSO_CLIENT_ID;

            cmd.ExecuteNonQuery();
        }

        // Обновить заявку
        public static void UpdateRequest(Request request)
        {
            using var conn = new NpgsqlConnection(ConnectionString);
            conn.Open();
            using var cmd = new NpgsqlCommand(@"
        UPDATE ""AVERS_DWH_NSO_REQUESTS"" SET
            ""CLIENT_ACC"" = @CLIENT_ACC,
            ""CREATE_DATE"" = @CREATE_DATE,
            ""SUMM"" = @SUMM,
            ""ADDAGGREMENT_NUM"" = @ADDAGGREMENT_NUM,
            ""PRC_STR"" = @PRC_STR,
            ""DATE_BEGIN"" = @DATE_BEGIN,
            ""DATE_END"" = @DATE_END,
            ""DAYS_COUNT"" = @DAYS_COUNT,
            ""PRC_JS_CALC"" = @PRC_JS_CALC,
            ""PRC_NUM"" = @PRC_NUM,
            ""DATE_BREAK"" = @DATE_BREAK,
            ""IS_ENDED"" = @IS_ENDED,
            ""ADDAGGREMENT_DATE"" = @ADDAGGREMENT_DATE,
            ""IKUSNUM"" = @IKUSNUM,
            ""CREATE_USER"" = @CREATE_USER,
            ""UPDATE_USER"" = @UPDATE_USER,
            ""UPDATE_DATE"" = @UPDATE_DATE,
            ""NOTE"" = @NOTE,
            ""ERR_MESSAGE"" = @ERR_MESSAGE,
            ""NSO_CLIENT_ID"" = @NSO_CLIENT_ID
        WHERE ""ID"" = @ID", conn);

            cmd.Parameters.Add("@ID", NpgsqlTypes.NpgsqlDbType.Integer).Value = request.ID;
            cmd.Parameters.Add("@CLIENT_ACC", NpgsqlTypes.NpgsqlDbType.Varchar).Value = request.CLIENT_ACC;
            cmd.Parameters.Add("@CREATE_DATE", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = request.CREATE_DATE;
            cmd.Parameters.Add("@SUMM", NpgsqlTypes.NpgsqlDbType.Varchar).Value = request.SUMM ?? (object)DBNull.Value;
            cmd.Parameters.Add("@ADDAGGREMENT_NUM", NpgsqlTypes.NpgsqlDbType.Varchar).Value = request.ADDAGGREMENT_NUM ?? (object)DBNull.Value;
            cmd.Parameters.Add("@PRC_STR", NpgsqlTypes.NpgsqlDbType.Varchar).Value = request.PRC_STR ?? (object)DBNull.Value;
            cmd.Parameters.Add("@DATE_BEGIN", NpgsqlTypes.NpgsqlDbType.Date).Value = request.DATE_BEGIN;
            cmd.Parameters.Add("@DATE_END", NpgsqlTypes.NpgsqlDbType.Date).Value = request.DATE_END ?? (object)DBNull.Value;
            cmd.Parameters.Add("@DAYS_COUNT", NpgsqlTypes.NpgsqlDbType.Varchar).Value = request.DAYS_COUNT ?? (object)DBNull.Value;
            cmd.Parameters.Add("@PRC_JS_CALC", NpgsqlTypes.NpgsqlDbType.Integer).Value = request.PRC_JS_CALC ?? (object)DBNull.Value;
            cmd.Parameters.Add("@PRC_NUM", NpgsqlTypes.NpgsqlDbType.Integer).Value = request.PRC_NUM ?? (object)DBNull.Value;
            cmd.Parameters.Add("@DATE_BREAK", NpgsqlTypes.NpgsqlDbType.Date).Value = request.DATE_BREAK ?? (object)DBNull.Value;
            cmd.Parameters.Add("@IS_ENDED", NpgsqlTypes.NpgsqlDbType.Integer).Value = request.IS_ENDED ?? (object)DBNull.Value;
            cmd.Parameters.Add("@ADDAGGREMENT_DATE", NpgsqlTypes.NpgsqlDbType.Date).Value = request.ADDAGGREMENT_DATE ?? (object)DBNull.Value;
            cmd.Parameters.Add("@IKUSNUM", NpgsqlTypes.NpgsqlDbType.Integer).Value = request.IKUSNUM;
            cmd.Parameters.Add("@CREATE_USER", NpgsqlTypes.NpgsqlDbType.Varchar).Value = request.CREATE_USER ?? (object)DBNull.Value;
            cmd.Parameters.Add("@UPDATE_USER", NpgsqlTypes.NpgsqlDbType.Varchar).Value = request.UPDATE_USER ?? (object)DBNull.Value;
            cmd.Parameters.Add("@UPDATE_DATE", NpgsqlTypes.NpgsqlDbType.Date).Value = request.UPDATE_DATE ?? (object)DBNull.Value;
            cmd.Parameters.Add("@NOTE", NpgsqlTypes.NpgsqlDbType.Varchar).Value = request.NOTE ?? (object)DBNull.Value;
            cmd.Parameters.Add("@ERR_MESSAGE", NpgsqlTypes.NpgsqlDbType.Varchar).Value = request.ERR_MESSAGE ?? (object)DBNull.Value;
            cmd.Parameters.Add("@NSO_CLIENT_ID", NpgsqlTypes.NpgsqlDbType.Integer).Value = request.NSO_CLIENT_ID;

            cmd.ExecuteNonQuery();
        }

        // Удалить заявку
        public static void DeleteRequest(int id)
        {
            using var conn = new NpgsqlConnection(ConnectionString);
            conn.Open();
            using var cmd = new NpgsqlCommand(@"DELETE FROM ""AVERS_DWH_NSO_REQUESTS"" WHERE ""ID"" = @ID", conn);
            cmd.Parameters.AddWithValue("ID", id);
            cmd.ExecuteNonQuery();
        }
    }
}