namespace HssUtility.Service.JSON
{
    public interface I_JSONful : I_RESTful
    {
        JSON_obj Convert_to_JSON();
        bool Read_from_JSON(JSON_obj jsObj);
    }
}
