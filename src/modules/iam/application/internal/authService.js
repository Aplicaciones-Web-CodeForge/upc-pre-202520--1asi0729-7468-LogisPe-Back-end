import { users } from "../../../users/infrastructure/persistence/memory/usersRepository.js";

export const loginUser = (email, password) => {
  const user = users.find(u => u.email === email && u.password === password);
  if (!user) return null;
  return { id: user.id, name: user.name, email: user.email, role: user.role };
};