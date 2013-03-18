namespace SqlLoaderEditor.Core
{
    /// <summary>
    /// Table-Specific Loading Method
    /// </summary>
    public enum LoadMethods
    {
        /// <summary>
        /// Appends data to an existing table.
        /// </summary>
        /// <remarks>
        /// If data already exists in the table, SQL*Loader appends the new rows to it.
        /// If data does not already exist, the new rows are simply loaded.
        /// You must have SELECT privilege to use the APPEND option.
        /// </remarks>
        Append,
        /// <summary>
        /// Load data to an empty table.
        /// </summary>
        /// <remarks>
        /// This is SQL*Loader's default method. 
        /// It requires the table to be empty before loading.
        /// SQL*Loader terminates with an error if the table contains rows
        /// </remarks>
        Insert,
        /// <summary>
        /// All rows in the table are deleted and the new data is loaded.
        /// </summary>
        /// <remarks>
        /// All rows in the table are deleted and the new data is loaded.
        /// The table must be in your schema, or you must have DELETE privilege on the table.
        /// </remarks>
        Replace,
        /// <summary>
        /// Deletes all rows from a table or cluster.
        /// </summary>
        /// <remarks>
        /// The SQL TRUNCATE statement quickly and efficiently deletes all rows from a table or cluster, to achieve the best possible performance.
        /// For the TRUNCATE statement to operate, the table's referential integrity constraints must first be disabled.
        /// If they have not been disabled, SQL*Loader returns an error.
        /// Once the integrity constraints have been disabled, DELETE CASCADE is no longer defined for the table.
        /// If the DELETE CASCADE functionality is needed, then the contents of the table must be manually deleted before the load begins.
        /// The table must be in your schema, or you must have the DROP ANY TABLE privilege.
        /// </remarks>
        Truncate
    }
}
