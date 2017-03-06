using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// IMemberRepostiory 的摘要描述
/// </summary>
public interface IMemberRepostiory
{
    /// <summary>
    /// 新增
    /// </summary>
    /// <param name="member"></param>
    void Add(Member member);

    /// <summary>
    /// 修改
    /// </summary>
    /// <param name="member"></param>
    void Update(Member member);

    /// <summary>
    /// 查詢所有
    /// </summary>
    /// <returns></returns>
    IEnumerable<Member_Get_Result> Get();

    /// <summary>
    /// 查詢
    /// </summary>
    /// <param name="No"></param>
    Member_GetByNo_Result GetByNo(int No);

    /// <summary>
    /// 刪除
    /// </summary>
    /// <param name="No"></param>
    void Delete(int No);
}
