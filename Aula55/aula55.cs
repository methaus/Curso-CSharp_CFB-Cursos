using System;
using System.Collections.Generic;

class Personagem {
	Dictionary<int, string> skills = new Dictionary<int, string>();
	int numSkills;
	public Personagem() {
		numSkills = 0;
	}
	public void AddSkill(string skillName) {
		skills.Add(++numSkills, skillName);
	}
	public void DeleteSkill(int skillId) {
		skills.Remove(skillId);
	}
	public void ClearSkills() {
		skills.Clear();
	}
	public int NumSkills() {
		return skills.Count;
	}
	public void SwapSkill(int skillId, string newSkillName) {
		skills[skillId] = newSkillName;
	}
	public bool TestSkill(int skillId) {
		return skills.ContainsKey(skillId);
	}
	public bool TestSkill(string skillName) {
		return skills.ContainsValue(skillName);
	}
	public string SearchSkill(int skillId) {
		return skills[skillId];
	}
}
class program {
	static void Main() {
		Personagem player = new Personagem();
		player.AddSkill("atacar");
		player.AddSkill("defender");
		Console.WriteLine("Seu personagem tem {0} habilidades",player.NumSkills());
		Console.WriteLine("Habilidade 1 = {0}",player.SearchSkill(1));
		Console.WriteLine("Habilidade 2 = {0}",player.SearchSkill(2));
		Console.WriteLine("Total de habilidades = {0}",player.NumSkills());
		Console.WriteLine("Seu personagem tem uma skill 0? {0}",player.TestSkill(0));
		Console.WriteLine("Seu personagem tem uma skill 1? {0}",player.TestSkill(1));
		Console.WriteLine("Seu personagem tem uma skill 2? {0}",player.TestSkill(2));
		Console.WriteLine("Trocar habilidade defender por correr...");
		player.SwapSkill(2, "correr");
		Console.WriteLine("Seu personagem tem uma skill atacar? {0}",player.TestSkill("atacar"));
		Console.WriteLine("Seu personagem tem uma skill defender? {0}",player.TestSkill("defender"));
		Console.WriteLine("Seu personagem tem uma skill correr? {0}",player.TestSkill("correr"));
		Console.Read();
	}
}
