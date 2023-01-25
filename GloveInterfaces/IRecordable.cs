
namespace GloveInterfaces
{

    # pragma warning disable CA1845, IDE0057
    public interface IRecordable
    {

        // Method to recover the name of its table

        public string GetTableName();
        
        // Method to get the concatenated field name of its table

        public string GetFieldsWithCommas();
        
        // Method to get the object data concatenated with commas

        public string MergedWithCommas();

        // Method to get the SQL Query to insert the object in its table

        public string GetInsertQuery()
        {
            return "INSERT INTO " + GetTableName() + "(" + GetFieldsWithCommas() + ") VALUES(" + MergedWithCommas() + ");";
        }

        // Method to get the Status Field name in its table

        public string GetStatusFieldName()
        {
            return GetTableName().Substring(0, 3) + "Estado";
        }

        // Method to get the Id Field name in its table

        public string GetIdFieldName()
        {
            return GetTableName().Substring(0, 3) + "Id";
        }

    }

}
