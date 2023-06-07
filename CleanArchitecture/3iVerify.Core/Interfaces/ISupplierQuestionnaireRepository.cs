using CleanArchitecture.Data;
using System.Threading.Tasks;

namespace CleanArchitecture.Core
{
	public interface ISupplierQuestionnaireRepository : IGenericRepository<SupplierQuestionnaire>
	{
		Task<bool> IsSupplierQuestSubmittedForApproval();
		Task<bool> IsSupplierQuestionnaireApproved();

	}
}
