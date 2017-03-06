using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// MemberRepostiory 的摘要描述
/// </summary>
public class MemberRepostiory: IMemberRepostiory
{
    private WCFEntities _wcfEntities;

    public MemberRepostiory()
    {
        _wcfEntities = new WCFEntities();
    }

    /// <summary>
    /// 新增
    /// </summary>
    /// <param name="member"></param>
    public void Add(Member member)
    {
        try
        {
            _wcfEntities.Member_Add(member.Name, member.Phone, member.CreateAccount, member.ModifyAccount, member.Flag);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    /// <summary>
    /// 修改
    /// </summary>
    /// <param name="member"></param>
    public void Update(Member member)
    {
        try
        {
            _wcfEntities.Member_Update(member.No,member.Name, member.Phone,member.ModifyAccount, member.Flag);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    /// <summary>
    /// 查詢所有
    /// </summary>
    /// <returns></returns>
    public IEnumerable<Member_Get_Result> Get()
    {
        try
        {
            return _wcfEntities.Member_Get();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    /// <summary>
    /// 查詢
    /// </summary>
    /// <param name="No"></param>
    public Member_GetByNo_Result GetByNo(int No)
    {
        try
        {
            return _wcfEntities.Member_GetByNo(No).FirstOrDefault();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    /// <summary>
    /// 刪除
    /// </summary>
    /// <param name="No"></param>
    public void Delete(int No)
    {
        try
        {
            _wcfEntities.Member_Delete(No);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}