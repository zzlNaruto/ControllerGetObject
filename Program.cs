var sr = new StreamReader(Request.InputStream);
var stream = sr.ReadToEnd();
JavaScriptSerializer js = new JavaScriptSerializer();
var query = js.Deserialize<RestfulQuery<Trt_Retired_Fail_DataOutput_RecordEntity>>(stream);
