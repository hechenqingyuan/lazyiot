﻿namespace Temporal.Net.InfluxDb.Constants
{
    internal static class QueryStatements
    {
        // NOTE: formatted time for WHERE clause needs to go in single quotes whereas downsampled serie name needs to go into double quotes

        public const string GetSeries = "SHOW SERIES";
        public const string DropSeries = "DROP SERIES FROM \"{0}\"";
        public const string GetMeasurements = "SHOW MEASUREMENTS ";
        public const string DropMeasurement = "DROP MEASUREMENT \"{0}\"";
        public const string ShowTagKeys = "SHOW TAG KEYS FROM \"{0}\"";
        public const string ShowTagValues = "SHOW TAG VALUES FROM \"{0}\" WITH KEY = \"{1}\"";
        public const string ShowFieldKeys = "SHOW FIELD KEYS FROM \"{0}\"";

        public const string CreateDatabase = "CREATE DATABASE \"{0}\"";
        public const string GetDatabases = "SHOW DATABASES";
        public const string DropDatabase = "DROP DATABASE \"{0}\"";

        public const string CreateRetentionPolicy = "CREATE RETENTION POLICY {0} ON {1} DURATION {2} REPLICATION {3}";
        public const string GetRetentionPolicies = "SHOW RETENTION POLICIES ON {0}";
        public const string AlterRetentionPolicy = "ALTER RETENTION POLICY {0} ON {1} DURATION {2} REPLICATION {3}";
        public const string DropRetentionPolicy = "DROP RETENTION POLICY {0} ON {1}";

        public const string CreateContinuousQuery = "CREATE CONTINUOUS QUERY {0} ON {1} {2}BEGIN {3} END;";
        public const string CreateContinuousQuerySubQuery = "SELECT {0} INTO \"{1}\" FROM {2} GROUP BY time({3}) {4} {5}";
        public const string GetContinuousQueries = "SHOW CONTINUOUS QUERIES";
        public const string DropContinuousQuery = "DROP CONTINUOUS QUERY {0} ON {1}";
        public const string Backfill = "SELECT {0} INTO \"{1}\" FROM {2} WHERE {3} time >= '{4}' AND time < '{5}' GROUP BY time({6}) {7} {8}";
        public const string Fill = "fill({0})";

        public const string GetStats = "SHOW STATS";
        public const string GetDiagnostics = "SHOW DIAGNOSTICS";

        public const string GetUsers = "SHOW USERS";
        public const string GetGrants = "SHOW GRANTS FOR \"{0}\"";
        public const string CreateUser = "CREATE USER \"{0}\" WITH PASSWORD '{1}'{2}";
        public const string DropUser = "DROP USER \"{0}\"";
        public const string SetPassword = "SET PASSWORD FOR \"{0}\" = '{1}'";
        public const string GrantAdministrator = "GRANT ALL PRIVILEGES TO \"{0}\"";
        public const string RevokeAdministrator = "REVOKE ALL PRIVILEGES FROM \"{0}\"";
        public const string GrantPrivilege = "GRANT {0} ON \"{1}\" TO \"{2}\"";
        public const string RevokePrivilege = "REVOKE {0} ON \"{1}\" FROM \"{2}\"";
        public const string WithAllPrivileges = " WITH ALL PRIVILEGES";
    }
}