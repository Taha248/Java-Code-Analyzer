using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class Github
    {
        IReadOnlyList<RepositoryContributor> Contributors;
        IReadOnlyList<GitHubCommit> Commits;

        public Github(IReadOnlyList<RepositoryContributor> contributors, IReadOnlyList<GitHubCommit> commits)
        {
            Contributors = contributors;
            Commits = commits;
        }

        public IReadOnlyList<RepositoryContributor> Contributors1
        {
            get
            {
                return Contributors;
            }

            set
            {
                Contributors = value;
            }
        }

        public IReadOnlyList<GitHubCommit> Commits1
        {
            get
            {
                return Commits;
            }

            set
            {
                Commits = value;
            }
        }

        public static implicit operator Task(Github v)
        {
            throw new NotImplementedException();
        }
    }
}
