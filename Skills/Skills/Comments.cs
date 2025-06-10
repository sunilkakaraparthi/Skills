// create a method that generates a comment for a given skill
using System;

namespace Skills
{
    public class Comments
    {
        /// <summary>
        /// Generates a comment for a given skill.
        /// </summary>
        /// <param name="skillName">The name of the skill.</param>
        /// <param name="description">A brief description of the skill.</param>
        /// <returns>A formatted comment string.</returns>
        public static string GenerateComment(string skillName, string description)
        {
            return $"Skill: {skillName}\nDescription: {description}";
        }
    }
}