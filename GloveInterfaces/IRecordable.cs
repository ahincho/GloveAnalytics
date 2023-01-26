
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

    }

}
