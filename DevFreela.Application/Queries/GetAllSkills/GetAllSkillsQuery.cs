using DevFreela.Application.Models.ViewModels;
using MediatR;

namespace DevFreela.Application.Queries.GetAllSkills
{
    public class GetAllSkillsQuery : IRequest<List<SkillViewModel>>
    {
    }
}
