import React from 'react';

function Header() {
  return (
    <header style={{ backgroundColor: '#003366', padding: '10px', color: 'white' }}>
      <h1>QAirlLine</h1>
      <nav>
        <ul style={{ listStyle: 'none', display: 'flex', gap: '20px' }}>
          <li>Explore</li>
          <li>Book</li>
          <li>Experience</li>
          <li>Privilege Club</li>
        </ul>
      </nav>
    </header>
  );
}

export default Header;
