using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// 注意: 您可以使用 [重構] 功能表上的 [重新命名] 命令同時變更程式碼和組態檔中的介面名稱 "IService"。
[ServiceContract]
public interface IService
{

	//[OperationContract]
 //   Member_GetByNo_Result GetByNo(int value);

	[OperationContract]
	CompositeType GetDataUsingDataContract(CompositeType composite);

    // TODO: 在此新增您的服務作業

    [OperationContract]
    void Add(Member member);

    [OperationContract]
    void Update(Member member);


    [OperationContract]
    IEnumerable<Member_Get_Result> Get();

    [OperationContract]
    Member_GetByNo_Result GetByNo(int No);

    [OperationContract]
    void Delete(int No);

}

//使用下列範例中所示的資料合約，新增複合型別至服務作業。
[DataContract]
public class CompositeType
{
	bool boolValue = true;
	string stringValue = "Hello ";

	[DataMember]
	public bool BoolValue
	{
		get { return boolValue; }
		set { boolValue = value; }
	}

	[DataMember]
	public string StringValue
	{
		get { return stringValue; }
		set { stringValue = value; }
	}
}
