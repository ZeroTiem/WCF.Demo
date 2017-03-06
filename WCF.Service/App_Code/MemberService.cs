using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// 注意: 您可以使用 [重構] 功能表上的 [重新命名] 命令同時變更程式碼、svc 和組態檔中的類別名稱 "Service"。
public class Service : IService
{
    private IMemberRepostiory _memberRepostiory;

    public Service()
    {
        _memberRepostiory = new MemberRepostiory();
    }

    /// <summary>
    /// 查詢所有
    /// </summary>
    /// <returns></returns>
    public IEnumerable<Member_Get_Result> Get()
    {
        return _memberRepostiory.Get();
    }

    /// <summary>
    /// 查詢 條件 No
    /// </summary>
    /// <param name="No"></param>
    /// <returns></returns>
    public Member_GetByNo_Result GetByNo(int No)
    {
        return _memberRepostiory.GetByNo(No);
    }

    /// <summary>
    /// 新增
    /// </summary>
    /// <param name="member"></param>
    public void Add(Member member)
    {
        _memberRepostiory.Add(member);
    }

    /// <summary>
    /// 查詢
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public void Update(Member member)
    {
        _memberRepostiory.Update(member);
    }

    /// <summary>
    /// 刪除
    /// </summary>
    /// <param name="No"></param>
    public void Delete(int No)
    {
        _memberRepostiory.Delete(No);
    }

    public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}
}
