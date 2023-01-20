
namespace GloveInterfaces
{
    
    public interface Recordable
    {

        /*
         * An Recordable Object is that object which has these two
         * methods, the first method returns table's name which has
         * the records. Then, the second method returns the fields
         * of the table (concatenated) and the last method returns
         * all the data which are part of the table
         */

        public string getTableName();
        public string getFieldsWithCommas();
        public string mergedWithCommas();

    }

}
