import React, { useState } from 'react';
import Header from './components/Header';
import Footer from './components/Footer';
import FlightSearchForm from './components/FlightSearchForm';
import SearchResults from './components/SearchResults';
import './App.css';

function App() {
  const [results, setResults] = useState([]);

  const handleSearch = (data) => {
    setResults([data]); // Cập nhật kết quả tìm kiếm
  };

  return (
    <div>
      <Header />
      <main>
        <h1>Chào mừng đến QAirLine!</h1>
        <p>Ứng dụng đặt vé máy bay của bạn.</p>
        <FlightSearchForm onSearch={handleSearch} />
        <SearchResults results={results} />
      </main>
      <Footer />
    </div>
  );
}

export default App;
