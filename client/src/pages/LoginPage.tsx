import axios from 'axios'
import { useState } from 'react';
import { useNavigate } from 'react-router-dom';
import api from '../api/axios';

export default function LoginPage() {
  const navigate = useNavigate();
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [error, setError] = useState('');

  async function handleSubmit(e: React.FormEvent) {
    e.preventDefault();
    try {
      const res = await api.post('/account/login', { email, password });
      const token = res.data.token;
      localStorage.setItem('token', token);
      api.defaults.headers.Authorization = `Bearer ${token}`;
      navigate('/tasks');
    } catch (err: unknown) {
  if (axios.isAxiosError(err)) {
    setError('Falha ao fazer login: ' + (err.response?.data?.message ?? err.message));
  } else {
    setError('Erro inesperado ao fazer login.');
  }
  console.error(err);
}

  }

  return (
    <div style={{ maxWidth: 400, margin: 'auto', padding: '2rem' }}>
      <h2>Login</h2>
      <form onSubmit={handleSubmit}>
        <div>
          <label>Email</label><br/>
          <input type="email" value={email} onChange={e => setEmail(e.target.value)} required />
        </div>
        <div style={{ marginTop: '1rem' }}>
          <label>Senha</label><br/>
          <input type="password" value={password} onChange={e => setPassword(e.target.value)} required />
        </div>
        {error && <div style={{ color: 'red', marginTop: '1rem' }}>{error}</div>}
        <button type="submit" style={{ marginTop: '1rem' }}>Entrar</button>
      </form>
    </div>
  );
}