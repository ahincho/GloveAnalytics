
namespace GloveInterfaces
{
    
    public interface Recordable
    {

        // Method to recover the name of its table

        public string getTableName();
        
        // Method to get the concatenated field name of its table

        public string getFieldsWithCommas();
        
        // Method to get the object data concatenated with commas

        public string mergedWithCommas();

        // Method to get the SQL Query to insert the object in its table

        public string getInsertQuery()
        {
            return "INSERT INTO " + getTableName() + "(" + getFieldsWithCommas() + ") VALUES(" + mergedWithCommas() + ");"
        }

        // Method to get the Status Field name in its table

        public string getStatusFieldName()
        {
            return getTableName().Substring(0, 3) + "Estado";
        }

        // Method to get the Id Field name in its table

        public string getIdFieldName()
        {
            return getTableName().Substring(0, 3) + "Id";
        }

    }

}
